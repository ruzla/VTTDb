import React from 'react';
import { Link } from 'react-router-dom';

class Navbar extends React.Component {

    render() {
        return (
        <div>
            <div>
                <h1>Vaultex DB</h1>
            </div>
            <div class="nav-links">
                <Link class="link" to="/">Home</Link>
                <Link class="link" to="/organisations">Organisations</Link>
                <Link class="link" to="/employees">Employees</Link>
            </div>            
        </div>
        )
    }
};

export default Navbar;
