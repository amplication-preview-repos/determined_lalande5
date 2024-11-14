import * as graphql from "@nestjs/graphql";
import { EstatisticasResolverBase } from "./base/estatisticas.resolver.base";
import { Estatisticas } from "./base/Estatisticas";
import { EstatisticasService } from "./estatisticas.service";

@graphql.Resolver(() => Estatisticas)
export class EstatisticasResolver extends EstatisticasResolverBase {
  constructor(protected readonly service: EstatisticasService) {
    super(service);
  }
}
