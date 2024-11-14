/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import * as graphql from "@nestjs/graphql";
import { GraphQLError } from "graphql";
import { isRecordNotFoundError } from "../../prisma.util";
import { MetaQueryPayload } from "../../util/MetaQueryPayload";
import { Reclamacoes } from "./Reclamacoes";
import { ReclamacoesCountArgs } from "./ReclamacoesCountArgs";
import { ReclamacoesFindManyArgs } from "./ReclamacoesFindManyArgs";
import { ReclamacoesFindUniqueArgs } from "./ReclamacoesFindUniqueArgs";
import { DeleteReclamacoesArgs } from "./DeleteReclamacoesArgs";
import { ReclamacoesService } from "../reclamacoes.service";
@graphql.Resolver(() => Reclamacoes)
export class ReclamacoesResolverBase {
  constructor(protected readonly service: ReclamacoesService) {}

  async _reclamacoesItemsMeta(
    @graphql.Args() args: ReclamacoesCountArgs
  ): Promise<MetaQueryPayload> {
    const result = await this.service.count(args);
    return {
      count: result,
    };
  }

  @graphql.Query(() => [Reclamacoes])
  async reclamacoesItems(
    @graphql.Args() args: ReclamacoesFindManyArgs
  ): Promise<Reclamacoes[]> {
    return this.service.reclamacoesItems(args);
  }

  @graphql.Query(() => Reclamacoes, { nullable: true })
  async reclamacoes(
    @graphql.Args() args: ReclamacoesFindUniqueArgs
  ): Promise<Reclamacoes | null> {
    const result = await this.service.reclamacoes(args);
    if (result === null) {
      return null;
    }
    return result;
  }

  @graphql.Mutation(() => Reclamacoes)
  async deleteReclamacoes(
    @graphql.Args() args: DeleteReclamacoesArgs
  ): Promise<Reclamacoes | null> {
    try {
      return await this.service.deleteReclamacoes(args);
    } catch (error) {
      if (isRecordNotFoundError(error)) {
        throw new GraphQLError(
          `No resource was found for ${JSON.stringify(args.where)}`
        );
      }
      throw error;
    }
  }
}