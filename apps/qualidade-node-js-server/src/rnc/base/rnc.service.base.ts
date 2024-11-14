/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import { PrismaService } from "../../prisma/prisma.service";
import { Prisma, Rnc as PrismaRnc } from "@prisma/client";

export class RncServiceBase {
  constructor(protected readonly prisma: PrismaService) {}

  async count(args: Omit<Prisma.RncCountArgs, "select">): Promise<number> {
    return this.prisma.rnc.count(args);
  }

  async rncs(args: Prisma.RncFindManyArgs): Promise<PrismaRnc[]> {
    return this.prisma.rnc.findMany(args);
  }
  async rnc(args: Prisma.RncFindUniqueArgs): Promise<PrismaRnc | null> {
    return this.prisma.rnc.findUnique(args);
  }
  async createRnc(args: Prisma.RncCreateArgs): Promise<PrismaRnc> {
    return this.prisma.rnc.create(args);
  }
  async updateRnc(args: Prisma.RncUpdateArgs): Promise<PrismaRnc> {
    return this.prisma.rnc.update(args);
  }
  async deleteRnc(args: Prisma.RncDeleteArgs): Promise<PrismaRnc> {
    return this.prisma.rnc.delete(args);
  }
}
