import { ReclamacoesWhereInput } from "./ReclamacoesWhereInput";
import { ReclamacoesOrderByInput } from "./ReclamacoesOrderByInput";

export type ReclamacoesFindManyArgs = {
  where?: ReclamacoesWhereInput;
  orderBy?: Array<ReclamacoesOrderByInput>;
  skip?: number;
  take?: number;
};
