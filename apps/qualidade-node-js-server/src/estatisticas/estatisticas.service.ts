import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { EstatisticasServiceBase } from "./base/estatisticas.service.base";

@Injectable()
export class EstatisticasService extends EstatisticasServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
