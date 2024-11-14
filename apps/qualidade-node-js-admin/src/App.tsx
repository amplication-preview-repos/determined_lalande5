import React, { useEffect, useState } from "react";
import { Admin, DataProvider, Resource } from "react-admin";
import dataProvider from "./data-provider/graphqlDataProvider";
import { theme } from "./theme/theme";
import Login from "./Login";
import "./App.scss";
import Dashboard from "./pages/Dashboard";
import { ReclamacoesList } from "./reclamacoes/ReclamacoesList";
import { ReclamacoesCreate } from "./reclamacoes/ReclamacoesCreate";
import { ReclamacoesEdit } from "./reclamacoes/ReclamacoesEdit";
import { ReclamacoesShow } from "./reclamacoes/ReclamacoesShow";
import { RncList } from "./rnc/RncList";
import { RncCreate } from "./rnc/RncCreate";
import { RncEdit } from "./rnc/RncEdit";
import { RncShow } from "./rnc/RncShow";
import { CausaRaizList } from "./causaRaiz/CausaRaizList";
import { CausaRaizCreate } from "./causaRaiz/CausaRaizCreate";
import { CausaRaizEdit } from "./causaRaiz/CausaRaizEdit";
import { CausaRaizShow } from "./causaRaiz/CausaRaizShow";
import { EstatisticasList } from "./estatisticas/EstatisticasList";
import { EstatisticasCreate } from "./estatisticas/EstatisticasCreate";
import { EstatisticasEdit } from "./estatisticas/EstatisticasEdit";
import { EstatisticasShow } from "./estatisticas/EstatisticasShow";
import { jwtAuthProvider } from "./auth-provider/ra-auth-jwt";

const App = (): React.ReactElement => {
  return (
    <div className="App">
      <Admin
        title={"QualidadeNodeJS"}
        dataProvider={dataProvider}
        authProvider={jwtAuthProvider}
        theme={theme}
        dashboard={Dashboard}
        loginPage={Login}
      >
        <Resource
          name="Reclamacoes"
          list={ReclamacoesList}
          edit={ReclamacoesEdit}
          create={ReclamacoesCreate}
          show={ReclamacoesShow}
        />
        <Resource
          name="Rnc"
          list={RncList}
          edit={RncEdit}
          create={RncCreate}
          show={RncShow}
        />
        <Resource
          name="CausaRaiz"
          list={CausaRaizList}
          edit={CausaRaizEdit}
          create={CausaRaizCreate}
          show={CausaRaizShow}
        />
        <Resource
          name="Estatisticas"
          list={EstatisticasList}
          edit={EstatisticasEdit}
          create={EstatisticasCreate}
          show={EstatisticasShow}
        />
      </Admin>
    </div>
  );
};

export default App;
