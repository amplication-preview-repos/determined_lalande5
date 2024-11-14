import * as graphql from "@nestjs/graphql";
import { ReclamacoesResolverBase } from "./base/reclamacoes.resolver.base";
import { Reclamacoes } from "./base/Reclamacoes";
import { ReclamacoesService } from "./reclamacoes.service";

@graphql.Resolver(() => Reclamacoes)
export class ReclamacoesResolver extends ReclamacoesResolverBase {
  constructor(protected readonly service: ReclamacoesService) {
    super(service);
  }
}
