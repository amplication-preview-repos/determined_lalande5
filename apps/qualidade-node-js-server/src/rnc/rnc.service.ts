import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { RncServiceBase } from "./base/rnc.service.base";

@Injectable()
export class RncService extends RncServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
