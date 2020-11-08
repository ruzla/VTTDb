import React, { Fragment } from 'react';
import axios from 'axios';

class Organisations extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
          organisations: [],
        };
    }

    componentDidMount() {
        axios.get('http://localhost:60734/api/vaultex/organisations')
          .then((response) => this.setState({ organisations: response.data }))
          .catch(() => console.log('Server error. Please try again later.'));
    }

    renderTable() {
        return this.state.organisations.map((organisations, index) => {
            const { id, organisationName, organisationNumber, addressLine1, addressLine2, addressLine3, addressLine4, town, postcode } = organisations;
            return (
                <tr key={id}>
                    <td>{organisationName}</td>
                    <td>{organisationNumber}</td>
                    <td>{addressLine1}</td>
                    <td>{addressLine2}</td>
                    <td>{addressLine3}</td>
                    <td>{addressLine4}</td>
                    <td>{town}</td>
                    <td>{postcode}</td>
                </tr>
            )
        })
    }

    render() {
        return (
          <Fragment>
             <div>
                 <h1>Organisations</h1>
                 <table id='organisations'>
                    <tr>
                        <th>OrganisationName</th>
                        <th>OrganisationNumber</th>
                        <th>AddressLine1</th>
                        <th>AddressLine2</th>
                        <th>AddressLine2</th>
                        <th>AddressLine4</th>
                        <th>Town</th>
                        <th>Postcode</th>
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
    
 
export default Organisations;