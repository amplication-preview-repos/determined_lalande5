import { CausaRaiz as TCausaRaiz } from "../api/causaRaiz/CausaRaiz";

export const CAUSARAIZ_TITLE_FIELD = "id";

export const CausaRaizTitle = (record: TCausaRaiz): string => {
  return record.id?.toString() || String(record.id);
};
