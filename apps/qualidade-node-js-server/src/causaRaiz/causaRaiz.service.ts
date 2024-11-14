import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { CausaRaizServiceBase } from "./base/causaRaiz.service.base";

@Injectable()
export class CausaRaizService extends CausaRaizServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
