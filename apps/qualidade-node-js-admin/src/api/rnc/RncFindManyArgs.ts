import { RncWhereInput } from "./RncWhereInput";
import { RncOrderByInput } from "./RncOrderByInput";

export type RncFindManyArgs = {
  where?: RncWhereInput;
  orderBy?: Array<RncOrderByInput>;
  skip?: number;
  take?: number;
};
