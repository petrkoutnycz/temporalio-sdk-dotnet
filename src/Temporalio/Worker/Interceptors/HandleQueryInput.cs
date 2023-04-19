using System.Collections.Generic;
using Temporalio.Api.Common.V1;
using Temporalio.Workflows;

namespace Temporalio.Worker.Interceptors
{
    /// <summary>
    /// Input for <see cref="WorkflowInboundInterceptor.HandleQuery" />.
    /// </summary>
    /// <param name="ID">Query ID.</param>
    /// <param name="Query">Query name.</param>
    /// <param name="Definition">Query definition.</param>
    /// <param name="Args">Query arguments.</param>
    /// <param name="Headers">Query headers.</param>
    public record HandleQueryInput(
        string ID,
        string Query,
        WorkflowQueryDefinition Definition,
        object?[] Args,
        IDictionary<string, Payload>? Headers);
}