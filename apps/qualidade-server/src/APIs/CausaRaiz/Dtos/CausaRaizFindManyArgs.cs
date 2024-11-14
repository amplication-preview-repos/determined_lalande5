using Microsoft.AspNetCore.Mvc;
using Qualidade.APIs.Common;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CausaRaizFindManyArgs : FindManyInput<CausaRaiz, CausaRaizWhereInput> { }
