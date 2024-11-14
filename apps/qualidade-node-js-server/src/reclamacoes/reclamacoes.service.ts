import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { ReclamacoesServiceBase } from "./base/reclamacoes.service.base";

@Injectable()
export class ReclamacoesService extends ReclamacoesServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
