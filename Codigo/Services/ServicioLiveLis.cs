using DM_BA_88A.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System;
using DM_BA_88A.Models;
using DM_BA_88A.Utils;
using DM_BA_88A.Forms;
using static DM_BA_88A.Forms.Resultados;
using System.Windows.Forms;

namespace DM_BA_88A.Services
{
    public class ServicioLiveLis
    {

        private static RestClient client;
        private static readonly RegistroLog log = new RegistroLog();
        private static readonly string nombreLog = InterfaceConfig.nombreLog + "_JSON";
        private Resultados formResultados; 

        public ServicioLiveLis()
        {
            var options = new RestClientOptions(InterfaceConfig.endPointBase) { MaxTimeout = -1, };
            client = new RestClient(options);
        }

        public void EnviarResultados(ResultadoAnalito resultado)
        {
            try
            {
                string token = ObtenerToken();
                if (token != null)
                {
                    EjecutarMensajeEstadosTerminal("Enviando resultados...", EnumEstados.Process);

                    RestRequest request = new RestRequest($"{InterfaceConfig.endPointResultados}", Method.Post)
                                .AddHeader("Authorization", $"Bearer {token}")
                                .AddHeader("Content-Type", "application/json")
                                .AddHeader("Client", $"{InterfaceConfig.client}")
                                .AddHeader("Cookie", "ARRAffinity=2bd31e84ea0f19c15dd402e7a497a7675b0400bcd5ce5ea73b2f33494c77e44f; ARRAffinitySameSite=2bd31e84ea0f19c15dd402e7a497a7675b0400bcd5ce5ea73b2f33494c77e44f")
                                .AddJsonBody(new
                                {
                                    resultado.sampleNumber,
                                    resultado.analyte,
                                    resultado.medicalDevice,
                                    resultado.reactive,
                                    resultado.result
                                });
                    log.RegistraEnLog($"----------------------------- Headers y Body enviados ------------------------", nombreLog);
                    log.RegistraEnLog($"RestRequest({InterfaceConfig.endPointBase}{InterfaceConfig.endPointResultados}, Method.Post", nombreLog);
                    log.RegistraEnLog($"Content-Type,\"application/json\"", nombreLog);
                    log.RegistraEnLog($"Client, {InterfaceConfig.client}", nombreLog);
                    log.RegistraEnLog($"Body{{sampleNumber = {resultado.sampleNumber}, analyte = {resultado.analyte}, medicalDevice = {resultado.medicalDevice}, reactive = {resultado.reactive}, result = {resultado.result}}} ", nombreLog);
                    log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);

                    RestResponse response = client.Execute(request);
                    RespuestaEnvioResultados respuestaEnvio = JsonConvert.DeserializeObject<RespuestaEnvioResultados>(response.Content);
                    log.RegistraEnLog($"------------------------- Respuesta Recibida ------------------------------", nombreLog);
                    if (response.IsSuccessful)
                    {
                        EjecutarMensajeEstadosTerminal("Resultados enviados.", EnumEstados.Ok);
                        log.RegistraEnLog($"Resultados enviados correctamente.", nombreLog);

                        if (respuestaEnvio.ok)
                        {
                            EjecutarMensajeEstadosTerminal($"Respuesta: {respuestaEnvio.message}", EnumEstados.Ok);
                            log.RegistraEnLog($"La respuesta del consumo fue positiva. Respuesta[{respuestaEnvio.message}]", nombreLog);
                            log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);
                        }
                        else
                        {
                            EjecutarMensajeEstadosTerminal($"Respuesta: {respuestaEnvio.message}", EnumEstados.Warning);
                            log.RegistraEnLog($"La respuesta del consumo fue negativa. Respuesta[{respuestaEnvio.message}]", nombreLog);
                            log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);
                        }
                    }
                    else
                    {
                        EjecutarMensajeEstadosTerminal($"Error enviando resultados. Status Code [{response.StatusCode}]", EnumEstados.Error);
                        ManejoExcepciones.ManejoErrores(response);
                    }
                }



            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                EjecutarMensajeEstadosTerminal($"Error enviando resultados. Mensaje interno [{ex.Message}]", EnumEstados.Error);
                EjecutarMensajeEstadosTerminal("Fin de procesamiento de resultados", EnumEstados.Ok);
                log.RegistraEnLog($"Error en EnviarResultados: {ex.Message}", nombreLog);
            }
        }
        private string ObtenerToken()
        {
            try
            {
                EjecutarMensajeEstadosTerminal("Obteniendo token...", EnumEstados.Process);
                
                RestRequest request = new RestRequest($"{InterfaceConfig.endPointToken}", Method.Post)
                    .AddHeader("Content-Type", "application/json")
                    .AddHeader("Client", $"{InterfaceConfig.client}")
                    .AddHeader("Cookie", "ARRAffinity=2bd31e84ea0f19c15dd402e7a497a7675b0400bcd5ce5ea73b2f33494c77e44f; ARRAffinitySameSite=2bd31e84ea0f19c15dd402e7a497a7675b0400bcd5ce5ea73b2f33494c77e44f")
                .AddJsonBody(new { InterfaceConfig.userName, InterfaceConfig.password });
                log.RegistraEnLog($"----------------------------- Headers y Body enviados ------------------------", nombreLog);
                log.RegistraEnLog($"RestRequest({InterfaceConfig.endPointBase}{InterfaceConfig.endPointToken}, Method.Post", nombreLog);
                log.RegistraEnLog($"Content-Type,\"application/json\"", nombreLog);
                log.RegistraEnLog($"Client,{InterfaceConfig.client}", nombreLog);
                log.RegistraEnLog($"Body{{UserName = {InterfaceConfig.userName}, Password {InterfaceConfig.password}}}", nombreLog);
                log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);

                RestResponse response = client.Execute(request);
                log.RegistraEnLog($"------------------------- Respuesta Recibida ------------------------------", nombreLog);
                if (response.IsSuccessful)
                {
                    RespuestaLoginToken respuestaLogin = JsonConvert.DeserializeObject<RespuestaLoginToken>(response.Content);
                    log.RegistraEnLog($"Token obtenido correctamente.", nombreLog);
                    log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);
                    EjecutarMensajeEstadosTerminal("Token obtenido correctamente.", EnumEstados.Ok);
                    return respuestaLogin.data.token;
                }
                else
                {
                    EjecutarMensajeEstadosTerminal($"Error obteniendo token. Status Code [{response.StatusCode}]", EnumEstados.Error);
                    ManejoExcepciones.ManejoErrores(response);
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                EjecutarMensajeEstadosTerminal($"Error obteniendo token. Mensaje interno [{ex.Message}]", EnumEstados.Error);
                log.RegistraEnLog($"Error en Obtener Token: {ex.Message}", nombreLog);
                return null;
            }
        }

        private void EjecutarMensajeEstadosTerminal(string msg, EnumEstados enumEstados)
        {
            try
            {
                formResultados = (Resultados)Application.OpenForms[1];
                formResultados.MensajesEstadosTerminal(msg, enumEstados);
            }
            catch (Exception)
            {
                using (var msFomr = new FormMessageBox("Interfaz Desconectada", "Advertencia")) { }
            }
        }
    }
}
