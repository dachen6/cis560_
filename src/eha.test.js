// JavaScript source code

import React from 'react';
import enzyme, { shallow, mount, render } from 'enzyme';
import { rander, screen, cleanup } from '@testing-library/react'
import Adapter from 'enzyme-adapter-react-16';
import NamePage from './NamePage.js';
import EnzymeAdapter from 'enzyme-adapter-react-16';
import { unmountComponentAtNode } from "react-dom";
import { Button, TextField } from '@material-ui/core';
import { BrowserRouter, MemoryRouter } from 'react-router-dom';
import App from "./App.js";
import renderer from 'react-test-renderer';
import { Link } from 'react-router-dom';
import { StaticRouter } from 'react-router'


enzyme.configure({ adapter: new Adapter() });
test("update parent", () => {
    global.window = { location: { pathname: null } };
    const mockCallBack = jest.fn();
    const wrapper = shallow(
        <BrowserRouter>
            <Button id="" className="sidebysidebutton" to="/selectionpage" component={Link} onClick={mockCallBack}>Next</Button>
        </BrowserRouter>
    );
   // console.debug(wrapper.debug())
    //console.debug(wrapper.html())
    wrapper.simulate('click');
    //expect(wrapper.find('a')).toHaveLength(1);
    //expect(mockCallBack.mock.calls.length).toEqual(1);
    expect(global.window.location.pathname).toEqual('/selectionpage');
});



test('Link matches snapshot', () => {
    
    const mockCallBack = jest.fn();
    const wrapper = renderer.create(
        <StaticRouter>
            <Button className="sidebysidebutton" onClick={mockCallBack}>Next</Button>
        </StaticRouter>
    );
    
    let tree = wrapper.toJSON();
    expect(tree).toMatchSnapshot();

});

