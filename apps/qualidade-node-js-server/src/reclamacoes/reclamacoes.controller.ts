import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { ReclamacoesService } from "./reclamacoes.service";
import { ReclamacoesControllerBase } from "./base/reclamacoes.controller.base";

@swagger.ApiTags("reclamacoes")
@common.Controller("reclamacoes")
export class ReclamacoesController extends ReclamacoesControllerBase {
  constructor(protected readonly service: ReclamacoesService) {
    super(service);
  }
}
