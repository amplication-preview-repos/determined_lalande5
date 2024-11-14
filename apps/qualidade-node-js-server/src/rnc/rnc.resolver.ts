import * as graphql from "@nestjs/graphql";
import { RncResolverBase } from "./base/rnc.resolver.base";
import { Rnc } from "./base/Rnc";
import { RncService } from "./rnc.service";

@graphql.Resolver(() => Rnc)
export class RncResolver extends RncResolverBase {
  constructor(protected readonly service: RncService) {
    super(service);
  }
}
