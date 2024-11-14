import { Module } from "@nestjs/common";
import { EstatisticasModuleBase } from "./base/estatisticas.module.base";
import { EstatisticasService } from "./estatisticas.service";
import { EstatisticasController } from "./estatisticas.controller";
import { EstatisticasResolver } from "./estatisticas.resolver";

@Module({
  imports: [EstatisticasModuleBase],
  controllers: [EstatisticasController],
  providers: [EstatisticasService, EstatisticasResolver],
  exports: [EstatisticasService],
})
export class EstatisticasModule {}
