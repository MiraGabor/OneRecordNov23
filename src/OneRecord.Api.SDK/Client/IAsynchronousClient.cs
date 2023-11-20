/*
 * ONE Record API Documentation
 *
 * This OpenAPI specification describes the API endpoint structure of an ONE Record API implementation.<br/><br/><b>Note:</b><br/>The included schemas can only be used to generate JSON-LD in the extended document form.<br/>However, to be fully ONE Record compliant, any ONE Record API (and any compliant ONE Record client)<br/><b>MUST</b> support at least the expanded, compacted, and flattened document forms.<br/><br/>More information about the ONE Record specification are available on [IATA Github repository](https://github.com/IATA-Cargo/ONE-Record) and on the [ONE Record Developer Portal](https://onerecord.iata.org).
 *
 * The version of the OpenAPI document: 2.0.0-dev
 * Contact: onerecord@iata.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Threading.Tasks;

namespace OneRecord.Api.SDK.Client
{
    /// <summary>
    /// Contract for Asynchronous RESTful API interactions.
    ///
    /// This interface allows consumers to provide a custom API accessor client.
    /// </summary>
    public interface IAsynchronousClient
    {
        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the GET http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> GetAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the POST http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> PostAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the PUT http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> PutAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the DELETE http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> DeleteAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the HEAD http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> HeadAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the OPTIONS http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> OptionsAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Executes a non-blocking call to some <paramref name="httpsPath"/> using the PATCH http verb.
        /// </summary>
        /// <param name="httpsPath">The relative path to invoke.</param>
        /// <param name="httpsOptions">The request parameters to pass along to the client.</param>
        /// <param name="httpsConfiguration">Per-request configurable settings.</param>
        /// <param name="httpsCancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}"/></returns>
        Task<ApiResponse<T>> PatchAsync<T>(string httpsPath, RequestOptions httpsOptions, IReadableConfiguration httpsConfiguration = null, System.Threading.CancellationToken httpsCancellationToken = default(System.Threading.CancellationToken));
    }
}
