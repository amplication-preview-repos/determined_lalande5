import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { CausaRaizService } from "./causaRaiz.service";
import { CausaRaizControllerBase } from "./base/causaRaiz.controller.base";

@swagger.ApiTags("causaRaizs")
@common.Controller("causaRaizs")
export class CausaRaizController extends CausaRaizControllerBase {
  constructor(protected readonly service: CausaRaizService) {
    super(service);
  }
}
