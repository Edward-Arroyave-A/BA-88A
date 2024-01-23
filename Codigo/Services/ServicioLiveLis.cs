using AnnarComMICROSESV60.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System;
using UrilyzerLiveLis100.Models;
using UrilyzerLiveLis100.Utils;

namespace UrilyzerLiveLis100.Services
{
    public class ServicioLiveLis
    {
        private static RestClient client;
        private static readonly RegistroLog log = new RegistroLog();
        private static readonly string nombreLog = InterfaceConfig.nombreLog + "_JSON";

        static ServicioLiveLis()
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
                        log.RegistraEnLog($"Resultados enviados correctamente.", nombreLog);
                        if (respuestaEnvio.ok)
                        {
                            log.RegistraEnLog($"La respuesta del consumo fue positiva. Respuesta[{respuestaEnvio.message}]", nombreLog);
                            log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);
                        }
                        else
                        {
                            log.RegistraEnLog($"La respuesta del consumo fue negativa. Respuesta[{respuestaEnvio.message}]", nombreLog);
                            log.RegistraEnLog($"-------------------------------------------------------------------------- \n", nombreLog);
                        }
                    }
                    else
                    {
                        ManejoExcepciones.ManejoErrores(response);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                log.RegistraEnLog($"Error en EnviarResultados: {ex.Message}", nombreLog);
            }
        }
        private string ObtenerToken()
        {
            try
            {
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
                    return respuestaLogin.data.token;
                }
                else
                {
                    ManejoExcepciones.ManejoErrores(response);
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                log.RegistraEnLog($"Error en ObtenerToken: {ex.Message}", nombreLog);
                return null;
            }
        }
    }
}
