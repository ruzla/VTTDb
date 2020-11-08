import { Fragment } from 'react';
import { Route, Switch } from 'react-router-dom';
import './App.css';
import Employees from './Components/employees';
import Organisations from './Components/organisations';
import NavBar from './Components/navbar';

function App() {
  return (  
      <Fragment>
        <NavBar />
        <Switch>
          <Route
            exact
            path="/"
          />
          <Route
            exact
            path="/employees"
            component={Employees}
          />
          <Route
            exact
            path="/organisations"
            component={Organisations}
          />
        </Switch>
      </Fragment>     
  );
}

export default App;
