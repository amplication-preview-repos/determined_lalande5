import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { EstatisticasService } from "./estatisticas.service";
import { EstatisticasControllerBase } from "./base/estatisticas.controller.base";

@swagger.ApiTags("estatisticas")
@common.Controller("estatisticas")
export class EstatisticasController extends EstatisticasControllerBase {
  constructor(protected readonly service: EstatisticasService) {
    super(service);
  }
}
