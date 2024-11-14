import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { RncService } from "./rnc.service";
import { RncControllerBase } from "./base/rnc.controller.base";

@swagger.ApiTags("rncs")
@common.Controller("rncs")
export class RncController extends RncControllerBase {
  constructor(protected readonly service: RncService) {
    super(service);
  }
}
