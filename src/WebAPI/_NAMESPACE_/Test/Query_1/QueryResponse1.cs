using _NAMESPACE_.Shared.Contracts.Responses;
using Test.Query_2;

namespace Test.Query_1
{
    public class QueryResponse1 : IResponse<Query1>, IResponse<Query2>
    {
    }
}
