import { Estatisticas as TEstatisticas } from "../api/estatisticas/Estatisticas";

export const ESTATISTICAS_TITLE_FIELD = "id";

export const EstatisticasTitle = (record: TEstatisticas): string => {
  return record.id?.toString() || String(record.id);
};
