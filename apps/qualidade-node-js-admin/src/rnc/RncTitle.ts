import { Rnc as TRnc } from "../api/rnc/Rnc";

export const RNC_TITLE_FIELD = "id";

export const RncTitle = (record: TRnc): string => {
  return record.id?.toString() || String(record.id);
};
