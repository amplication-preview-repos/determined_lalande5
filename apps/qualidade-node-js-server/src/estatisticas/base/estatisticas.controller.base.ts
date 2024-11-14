/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { isRecordNotFoundError } from "../../prisma.util";
import * as errors from "../../errors";
import { Request } from "express";
import { plainToClass } from "class-transformer";
import { ApiNestedQuery } from "../../decorators/api-nested-query.decorator";
import { EstatisticasService } from "../estatisticas.service";
import { EstatisticasCreateInput } from "./EstatisticasCreateInput";
import { Estatisticas } from "./Estatisticas";
import { EstatisticasFindManyArgs } from "./EstatisticasFindManyArgs";
import { EstatisticasWhereUniqueInput } from "./EstatisticasWhereUniqueInput";
import { EstatisticasUpdateInput } from "./EstatisticasUpdateInput";

export class EstatisticasControllerBase {
  constructor(protected readonly service: EstatisticasService) {}
  @common.Post()
  @swagger.ApiCreatedResponse({ type: Estatisticas })
  async createEstatisticas(
    @common.Body() data: EstatisticasCreateInput
  ): Promise<Estatisticas> {
    return await this.service.createEstatisticas({
      data: data,
      select: {
        createdAt: true,
        id: true,
        updatedAt: true,
      },
    });
  }

  @common.Get()
  @swagger.ApiOkResponse({ type: [Estatisticas] })
  @ApiNestedQuery(EstatisticasFindManyArgs)
  async estatisticasItems(
    @common.Req() request: Request
  ): Promise<Estatisticas[]> {
    const args = plainToClass(EstatisticasFindManyArgs, request.query);
    return this.service.estatisticasItems({
      ...args,
      select: {
        createdAt: true,
        id: true,
        updatedAt: true,
      },
    });
  }

  @common.Get("/:id")
  @swagger.ApiOkResponse({ type: Estatisticas })
  @swagger.ApiNotFoundResponse({ type: errors.NotFoundException })
  async estatisticas(
    @common.Param() params: EstatisticasWhereUniqueInput
  ): Promise<Estatisticas | null> {
    const result = await this.service.estatisticas({
      where: params,
      select: {
        createdAt: true,
        id: true,
        updatedAt: true,
      },
    });
    if (result === null) {
      throw new errors.NotFoundException(
        `No resource was found for ${JSON.stringify(params)}`
      );
    }
    return result;
  }

  @common.Patch("/:id")
  @swagger.ApiOkResponse({ type: Estatisticas })
  @swagger.ApiNotFoundResponse({ type: errors.NotFoundException })
  async updateEstatisticas(
    @common.Param() params: EstatisticasWhereUniqueInput,
    @common.Body() data: EstatisticasUpdateInput
  ): Promise<Estatisticas | null> {
    try {
      return await this.service.updateEstatisticas({
        where: params,
        data: data,
        select: {
          createdAt: true,
          id: true,
          updatedAt: true,
        },
      });
    } catch (error) {
      if (isRecordNotFoundError(error)) {
        throw new errors.NotFoundException(
          `No resource was found for ${JSON.stringify(params)}`
        );
      }
      throw error;
    }
  }

  @common.Delete("/:id")
  @swagger.ApiOkResponse({ type: Estatisticas })
  @swagger.ApiNotFoundResponse({ type: errors.NotFoundException })
  async deleteEstatisticas(
    @common.Param() params: EstatisticasWhereUniqueInput
  ): Promise<Estatisticas | null> {
    try {
      return await this.service.deleteEstatisticas({
        where: params,
        select: {
          createdAt: true,
          id: true,
          updatedAt: true,
        },
      });
    } catch (error) {
      if (isRecordNotFoundError(error)) {
        throw new errors.NotFoundException(
          `No resource was found for ${JSON.stringify(params)}`
        );
      }
      throw error;
    }
  }
}