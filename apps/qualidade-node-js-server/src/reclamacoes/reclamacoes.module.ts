import { Module } from "@nestjs/common";
import { ReclamacoesModuleBase } from "./base/reclamacoes.module.base";
import { ReclamacoesService } from "./reclamacoes.service";
import { ReclamacoesController } from "./reclamacoes.controller";
import { ReclamacoesResolver } from "./reclamacoes.resolver";

@Module({
  imports: [ReclamacoesModuleBase],
  controllers: [ReclamacoesController],
  providers: [ReclamacoesService, ReclamacoesResolver],
  exports: [ReclamacoesService],
})
export class ReclamacoesModule {}
