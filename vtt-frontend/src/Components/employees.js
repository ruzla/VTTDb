import React, { Fragment } from 'react';
import axios from 'axios';

class Employees extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
          employees: [],
          alertMessage: '',
          error: false,
        };
    }

    componentDidMount() {
        axios.get('http://localhost:60734/api/vaultex/employees')
          .then((response) => this.setState({ employees: response.data }))
          .catch(() => console.log('Server error. Please try again later.'))
    }
   

    renderTable() {
        return this.state.employees.map((employees, index) => {
            const { id, organisationNumber, firstName, lastName} = employees
            return (
                <tr key={id}>
                    <td>{organisationNumber}</td>
                    <td>{firstName}</td>
                    <td>{lastName}</td>
                </tr>
            )
        })
    }

    render() {
        return (
          <Fragment>
             <div>
                 <h1>Employees</h1>
                 <table id='employees'>
                    <tr>
                        <th>OrganisationNumber</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                    </tr>
                    <tbody>
                        {this.renderTable()}
                    </tbody>
                </table>
             </div>
          </Fragment>
        );
    }
}
    
export default Employees;
