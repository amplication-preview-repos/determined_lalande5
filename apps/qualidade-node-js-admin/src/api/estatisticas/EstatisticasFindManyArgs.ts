import { EstatisticasWhereInput } from "./EstatisticasWhereInput";
import { EstatisticasOrderByInput } from "./EstatisticasOrderByInput";

export type EstatisticasFindManyArgs = {
  where?: EstatisticasWhereInput;
  orderBy?: Array<EstatisticasOrderByInput>;
  skip?: number;
  take?: number;
};
