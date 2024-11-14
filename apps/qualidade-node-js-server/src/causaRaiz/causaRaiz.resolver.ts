import * as graphql from "@nestjs/graphql";
import { CausaRaizResolverBase } from "./base/causaRaiz.resolver.base";
import { CausaRaiz } from "./base/CausaRaiz";
import { CausaRaizService } from "./causaRaiz.service";

@graphql.Resolver(() => CausaRaiz)
export class CausaRaizResolver extends CausaRaizResolverBase {
  constructor(protected readonly service: CausaRaizService) {
    super(service);
  }
}
