using Entities.RequestFeatures;
using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace Entities.DataTransferObjects
{
    public record LinkParameters
    {
        public BookParameters BookParameters { get; init; }
        public HttpContext HttpContext { get; init; }
    }
}