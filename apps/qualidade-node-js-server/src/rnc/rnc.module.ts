import { Module } from "@nestjs/common";
import { RncModuleBase } from "./base/rnc.module.base";
import { RncService } from "./rnc.service";
import { RncController } from "./rnc.controller";
import { RncResolver } from "./rnc.resolver";

@Module({
  imports: [RncModuleBase],
  controllers: [RncController],
  providers: [RncService, RncResolver],
  exports: [RncService],
})
export class RncModule {}
