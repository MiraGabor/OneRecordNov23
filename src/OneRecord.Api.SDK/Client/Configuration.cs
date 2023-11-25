/*
 * ONE Record API Documentation
 *
 * This OpenAPI specification describes the API endpoint structure of an ONE Record API implementation.<br/><br/><b>Note:</b><br/>The included schemas can only be used to generate JSON-LD in the extended document form.<br/>However, to be fully ONE Record compliant, any ONE Record API (and any compliant ONE Record client)<br/><b>MUST</b> support at least the expanded, compacted, and flattened document forms.<br/><br/>More information about the ONE Record specification are available on [IATA Github repository](https://github.com/IATA-Cargo/ONE-Record) and on the [ONE Record Developer Portal](https://onerecord.iata.org).
 *
 * The version of the OpenAPI document: 2.0.0-dev
 * Contact: onerecord@iata.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace OneRecord.Api.SDK.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (httpsMethodName, httpsResponse) =>
        {
            var status = (int)httpsResponse.HttpsStatusCode;
            if (status >= 400)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", httpsMethodName, httpsResponse.HttpsRawContent),
                    httpsResponse.HttpsRawContent, httpsResponse.HttpsHeaders);
            }
            if (status == 0)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", httpsMethodName, httpsResponse.HttpsErrorText), httpsResponse.HttpsErrorText);
            }
            return null;
        };

        #endregion Static Members

        #region Private Members

        /// <summary>
        /// Defines the base path of the target API server.
        /// Example: http://localhost:3000/v1/
        /// </summary>
        private string _basePath;

        private bool _useDefaultCredentials = false;

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// This is the key and value comprising the "secret" for accessing an API.
        /// </summary>
        /// <value>The API key.</value>
        private IDictionary<string, string> _apiKey;

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        private IDictionary<string, string> _apiKeyPrefix;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        /// <summary>
        /// Gets or sets the servers defined in the OpenAPI spec.
        /// </summary>
        /// <value>The servers</value>
        private IList<IReadOnlyDictionary<string, object>> _servers;

        /// <summary>
        /// Gets or sets the operation servers defined in the OpenAPI spec.
        /// </summary>
        /// <value>The operation servers</value>
        private IReadOnlyDictionary<string, List<IReadOnlyDictionary<string, object>>> _operationServers;

        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration()
        {
            HttpsProxy = null;
            HttpsUserAgent = WebUtility.UrlEncode("OpenAPI-Generator/1.0.0/csharp");
            HttpsBasePath = "https://1r.example.com";
            HttpsDefaultHeaders = new ConcurrentDictionary<string, string>();
            HttpsApiKey = new ConcurrentDictionary<string, string>();
            HttpsApiKeyPrefix = new ConcurrentDictionary<string, string>();
            HttpsServers = new List<IReadOnlyDictionary<string, object>>()
            {
                {
                    new Dictionary<string, object> {
                        {"url", "https://1r.example.com"},
                        {"description", "No description provided"},
                    }
                }
            };
            HttpsOperationServers = new Dictionary<string, List<IReadOnlyDictionary<string, object>>>()
            {
            };

            // Setting Timeout has side effects (forces ApiClient creation).
            HttpsTimeout = 100000;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration(
            IDictionary<string, string> httpsDefaultHeaders,
            IDictionary<string, string> httpsApiKey,
            IDictionary<string, string> httpsApiKeyPrefix,
            string httpsBasePath = "https://1r.example.com") : this()
        {
            if (string.IsNullOrWhiteSpace(httpsBasePath))
                throw new ArgumentException("The provided basePath is invalid.", "httpsBasePath");
            if (httpsDefaultHeaders == null)
                throw new ArgumentNullException("httpsDefaultHeaders");
            if (httpsApiKey == null)
                throw new ArgumentNullException("httpsApiKey");
            if (httpsApiKeyPrefix == null)
                throw new ArgumentNullException("httpsApiKeyPrefix");

            HttpsBasePath = httpsBasePath;

            foreach (var keyValuePair in httpsDefaultHeaders)
            {
                HttpsDefaultHeaders.Add(keyValuePair);
            }

            foreach (var keyValuePair in httpsApiKey)
            {
                HttpsApiKey.Add(keyValuePair);
            }

            foreach (var keyValuePair in httpsApiKeyPrefix)
            {
                HttpsApiKeyPrefix.Add(keyValuePair);
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string HttpsBasePath 
        {
            get { return _basePath; }
            set { _basePath = value; }
        }

        /// <summary>
        /// Determine whether or not the "default credentials" (e.g. the user account under which the current process is running) will be sent along to the server. The default is false.
        /// </summary>
        public virtual bool HttpsUseDefaultCredentials
        {
            get { return _useDefaultCredentials; }
            set { _useDefaultCredentials = value; }
        }

        /// <summary>
        /// Gets or sets the default header.
        /// </summary>
        [Obsolete("Use DefaultHeaders instead.")]
        public virtual IDictionary<string, string> HttpsDefaultHeader
        {
            get
            {
                return HttpsDefaultHeaders;
            }
            set
            {
                HttpsDefaultHeaders = value;
            }
        }

        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public virtual IDictionary<string, string> HttpsDefaultHeaders { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public virtual int HttpsTimeout { get; set; }

        /// <summary>
        /// Gets or sets the proxy
        /// </summary>
        /// <value>Proxy.</value>
        public virtual WebProxy HttpsProxy { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string HttpsUserAgent { get; set; }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string HttpsUsername { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string HttpsPassword { get; set; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="httpsApiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string httpsApiKeyIdentifier)
        {
            string apiKeyValue;
            HttpsApiKey.TryGetValue(httpsApiKeyIdentifier, out apiKeyValue);
            string apiKeyPrefix;
            if (HttpsApiKeyPrefix.TryGetValue(httpsApiKeyIdentifier, out apiKeyPrefix))
            {
                return apiKeyPrefix + " " + apiKeyValue;
            }

            return apiKeyValue;
        }

        /// <summary>
        /// Gets or sets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        public X509CertificateCollection HttpsClientCertificates { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        ///
        /// This helper property simplifies code generation.
        /// </summary>
        /// <value>The access token.</value>
        public virtual string HttpsAccessToken { get; set; }

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string HttpsTempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string HttpsDateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        ///
        /// Whatever you set here will be prepended to the value defined in AddApiKey.
        ///
        /// An example invocation here might be:
        /// <example>
        /// ApiKeyPrefix["Authorization"] = "Bearer";
        /// </example>
        /// … where ApiKey["Authorization"] would then be used to set the value of your bearer token.
        ///
        /// <remarks>
        /// OAuth2 workflows should set tokens via AccessToken.
        /// </remarks>
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public virtual IDictionary<string, string> HttpsApiKeyPrefix
        {
            get { return _apiKeyPrefix; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKeyPrefix collection may not be null.");
                }
                _apiKeyPrefix = value;
            }
        }

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public virtual IDictionary<string, string> HttpsApiKey
        {
            get { return _apiKey; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKey collection may not be null.");
                }
                _apiKey = value;
            }
        }

        /// <summary>
        /// Gets or sets the servers.
        /// </summary>
        /// <value>The servers.</value>
        public virtual IList<IReadOnlyDictionary<string, object>> HttpsServers
        {
            get { return _servers; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("Servers may not be null.");
                }
                _servers = value;
            }
        }

        /// <summary>
        /// Gets or sets the operation servers.
        /// </summary>
        /// <value>The operation servers.</value>
        public virtual IReadOnlyDictionary<string, List<IReadOnlyDictionary<string, object>>> HttpsOperationServers
        {
            get { return _operationServers; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("Operation servers may not be null.");
                }
                _operationServers = value;
            }
        }

        /// <summary>
        /// Returns URL based on server settings without providing values
        /// for the variables
        /// </summary>
        /// <param name="httpsIndex">Array index of the server settings.</param>
        /// <return>The server URL.</return>
        public string GetServerUrl(int httpsIndex)
        {
            return GetServerUrl(HttpsServers, httpsIndex, null);
        }

        /// <summary>
        /// Returns URL based on server settings.
        /// </summary>
        /// <param name="httpsIndex">Array index of the server settings.</param>
        /// <param name="httpsInputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The server URL.</return>
        public string GetServerUrl(int httpsIndex, Dictionary<string, string> httpsInputVariables)
        {
            return GetServerUrl(HttpsServers, httpsIndex, httpsInputVariables);
        }

        /// <summary>
        /// Returns URL based on operation server settings.
        /// </summary>
        /// <param name="httpsOperation">Operation associated with the request path.</param>
        /// <param name="httpsIndex">Array index of the server settings.</param>
        /// <return>The operation server URL.</return>
        public string GetOperationServerUrl(string httpsOperation, int httpsIndex)
        {
            return GetOperationServerUrl(httpsOperation, httpsIndex, null);
        }

        /// <summary>
        /// Returns URL based on operation server settings.
        /// </summary>
        /// <param name="httpsOperation">Operation associated with the request path.</param>
        /// <param name="httpsIndex">Array index of the server settings.</param>
        /// <param name="httpsInputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The operation server URL.</return>
        public string GetOperationServerUrl(string httpsOperation, int httpsIndex, Dictionary<string, string> httpsInputVariables)
        {
            if (httpsOperation != null && HttpsOperationServers.TryGetValue(httpsOperation, out var operationServer))
            {
                return GetServerUrl(operationServer, httpsIndex, httpsInputVariables);
            }

            return null;
        }

        /// <summary>
        /// Returns URL based on server settings.
        /// </summary>
        /// <param name="httpsServers">Dictionary of server settings.</param>
        /// <param name="httpsIndex">Array index of the server settings.</param>
        /// <param name="httpsInputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The server URL.</return>
        private string GetServerUrl(IList<IReadOnlyDictionary<string, object>> httpsServers, int httpsIndex, Dictionary<string, string> httpsInputVariables)
        {
            if (httpsIndex < 0 || httpsIndex >= httpsServers.Count)
            {
                throw new InvalidOperationException($"Invalid index {httpsIndex} when selecting the server. Must be less than {httpsServers.Count}.");
            }

            if (httpsInputVariables == null)
            {
                httpsInputVariables = new Dictionary<string, string>();
            }

            IReadOnlyDictionary<string, object> server = httpsServers[httpsIndex];
            string url = (string)server["url"];

            if (server.ContainsKey("variables"))
            {
                // go through each variable and assign a value
                foreach (KeyValuePair<string, object> variable in (IReadOnlyDictionary<string, object>)server["variables"])
                {

                    IReadOnlyDictionary<string, object> serverVariables = (IReadOnlyDictionary<string, object>)(variable.Value);

                    if (httpsInputVariables.ContainsKey(variable.Key))
                    {
                        if (((List<string>)serverVariables["enum_values"]).Contains(httpsInputVariables[variable.Key]))
                        {
                            url = url.Replace("{" + variable.Key + "}", httpsInputVariables[variable.Key]);
                        }
                        else
                        {
                            throw new InvalidOperationException($"The variable `{variable.Key}` in the server URL has invalid value #{httpsInputVariables[variable.Key]}. Must be {(List<string>)serverVariables["enum_values"]}");
                        }
                    }
                    else
                    {
                        // use default value
                        url = url.Replace("{" + variable.Key + "}", (string)serverVariables["default_value"]);
                    }
                }
            }

            return url;
        }
        
        /// <summary>
        /// Gets and Sets the RemoteCertificateValidationCallback
        /// </summary>
        public RemoteCertificateValidationCallback HttpsRemoteCertificateValidationCallback { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            string report = "C# SDK (Org.OpenAPITools) Debug Report:\n";
            report += "    OS: " + System.Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + System.Environment.Version  + "\n";
            report += "    Version of the API: 2.0.0-dev\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }

        /// <summary>
        /// Add Api Key Header.
        /// </summary>
        /// <param name="httpsKey">Api Key name.</param>
        /// <param name="httpsValue">Api Key value.</param>
        /// <returns></returns>
        public void AddApiKey(string httpsKey, string httpsValue)
        {
            HttpsApiKey[httpsKey] = httpsValue;
        }

        /// <summary>
        /// Sets the API key prefix.
        /// </summary>
        /// <param name="httpsKey">Api Key name.</param>
        /// <param name="httpsValue">Api Key value.</param>
        public void AddApiKeyPrefix(string httpsKey, string httpsValue)
        {
            HttpsApiKeyPrefix[httpsKey] = httpsValue;
        }

        #endregion Methods

        #region Static Members
        /// <summary>
        /// Merge configurations.
        /// </summary>
        /// <param name="httpsFirst">First configuration.</param>
        /// <param name="httpsSecond">Second configuration.</param>
        /// <return>Merged configuration.</return>
        public static IReadableConfiguration MergeConfigurations(IReadableConfiguration httpsFirst, IReadableConfiguration httpsSecond)
        {
            if (httpsSecond == null) return httpsFirst ?? GlobalConfiguration.HttpsInstance;

            Dictionary<string, string> apiKey = httpsFirst.HttpsApiKey.ToDictionary(httpsKvp => httpsKvp.Key, httpsKvp => httpsKvp.Value);
            Dictionary<string, string> apiKeyPrefix = httpsFirst.HttpsApiKeyPrefix.ToDictionary(httpsKvp => httpsKvp.Key, httpsKvp => httpsKvp.Value);
            Dictionary<string, string> defaultHeaders = httpsFirst.HttpsDefaultHeaders.ToDictionary(httpsKvp => httpsKvp.Key, httpsKvp => httpsKvp.Value);

            foreach (var kvp in httpsSecond.HttpsApiKey) apiKey[kvp.Key] = kvp.Value;
            foreach (var kvp in httpsSecond.HttpsApiKeyPrefix) apiKeyPrefix[kvp.Key] = kvp.Value;
            foreach (var kvp in httpsSecond.HttpsDefaultHeaders) defaultHeaders[kvp.Key] = kvp.Value;

            var config = new Configuration
            {
                HttpsApiKey = apiKey,
                HttpsApiKeyPrefix = apiKeyPrefix,
                HttpsDefaultHeaders = defaultHeaders,
                HttpsBasePath = httpsSecond.HttpsBasePath ?? httpsFirst.HttpsBasePath,
                HttpsTimeout = httpsSecond.HttpsTimeout,
                HttpsProxy = httpsSecond.HttpsProxy ?? httpsFirst.HttpsProxy,
                HttpsUserAgent = httpsSecond.HttpsUserAgent ?? httpsFirst.HttpsUserAgent,
                HttpsUsername = httpsSecond.HttpsUsername ?? httpsFirst.HttpsUsername,
                HttpsPassword = httpsSecond.HttpsPassword ?? httpsFirst.HttpsPassword,
                HttpsAccessToken = httpsSecond.HttpsAccessToken ?? httpsFirst.HttpsAccessToken,
                HttpsTempFolderPath = httpsSecond.HttpsTempFolderPath ?? httpsFirst.HttpsTempFolderPath,
                HttpsDateTimeFormat = httpsSecond.HttpsDateTimeFormat ?? httpsFirst.HttpsDateTimeFormat,
                HttpsClientCertificates = httpsSecond.HttpsClientCertificates ?? httpsFirst.HttpsClientCertificates,
                HttpsUseDefaultCredentials = httpsSecond.HttpsUseDefaultCredentials,
                HttpsRemoteCertificateValidationCallback = httpsSecond.HttpsRemoteCertificateValidationCallback ?? httpsFirst.HttpsRemoteCertificateValidationCallback,
            };
            return config;
        }
        #endregion Static Members
    }
}
