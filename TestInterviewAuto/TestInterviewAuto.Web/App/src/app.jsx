import React from 'react';
import ReactDOM from 'react-dom';
import Header from './header/header.jsx';
import { BrowserRouter as Router, Route, Switch} from 'react-router-dom';

export default class App extends React.Component {
    render() {
        return (
            <Router>
                <div>
                    <Header />
                    <main>
                        <Switch>
                        </Switch>
                    </main>
                </div>
            </Router>
        );
    }
};