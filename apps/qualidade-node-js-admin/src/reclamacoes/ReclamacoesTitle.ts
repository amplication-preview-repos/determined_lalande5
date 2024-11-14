import { Reclamacoes as TReclamacoes } from "../api/reclamacoes/Reclamacoes";

export const RECLAMACOES_TITLE_FIELD = "id";

export const ReclamacoesTitle = (record: TReclamacoes): string => {
  return record.id?.toString() || String(record.id);
};
