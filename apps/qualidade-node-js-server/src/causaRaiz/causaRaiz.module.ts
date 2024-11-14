import { Module } from "@nestjs/common";
import { CausaRaizModuleBase } from "./base/causaRaiz.module.base";
import { CausaRaizService } from "./causaRaiz.service";
import { CausaRaizController } from "./causaRaiz.controller";
import { CausaRaizResolver } from "./causaRaiz.resolver";

@Module({
  imports: [CausaRaizModuleBase],
  controllers: [CausaRaizController],
  providers: [CausaRaizService, CausaRaizResolver],
  exports: [CausaRaizService],
})
export class CausaRaizModule {}
