

import React from 'react';
import enzyme, { shallow, mount, render } from 'enzyme';
import { rander, screen, cleanup } from '@testing-library/react'
import Adapter from 'enzyme-adapter-react-16';
import NamePage from './NamePage.js';
import EnzymeAdapter from 'enzyme-adapter-react-16';
import { unmountComponentAtNode } from "react-dom";
import { Button, TextField } from '@material-ui/core';
let container = null;
beforeEach(() => {
    
    container = document.createElement("div");
    document.body.appendChild(container);
});

afterEach(() => {
    
    unmountComponentAtNode(container);
    container.remove();
    container = null;
});
describe("ParentComponent", () => {
    /*let mount;

    enzyme.configure({ adapter: new Adapter() })

    it('should call onChange prop', () => {
        
        const event = {
            target: { value: 'the-value' }
        };
        const onSearchMock = jest.fn();
        const component = enzyme.shallow(<NamePage updateParent={onSearchMock} />);
        component.find('TextField').simulate('change', event);
        expect(onSearchMock).toBeCalledWith('the-value');
    });*/

  

})

describe('Test Button component', () => {
    enzyme.configure({ adapter: new Adapter() });
    it('Test click event', () => {
        const mockCallBack = jest.fn();

        const button = shallow((<Button onClick={mockCallBack}>Next</Button>));
        // button.find('NextButton').simulate('click');
        button.simulate('click');
        expect(mockCallBack.mock.calls.length).toEqual(1);
    });
});





test("render without error", () => {
    enzyme.configure({ adapter: new Adapter() });
    const wrapper = shallow(<NamePage />);
    const appComponent = wrapper.find('div');
    expect(appComponent.exists()).toBe(true);
});


/*test("clicking button increments counter display", () => {
    const name = "testname";
    const wrapper = shallow(<NamePage />);

    wrapper.setState({name });
    // find button and click
    const button = wrapper.find('#increment-button');
    button.simulate("click");
    // find display and test value
    const counterDisplay = wrapper.find('#icounter-display');
    expect(counterDisplay.text()).toContain(8);



});*/

describe('gotoNextpage', () => {
    enzyme.configure({ adapter: new Adapter() });
    it('Test click event', () => {
        const mockCallBack = jest.fn();

        const button = shallow((<Button onClick={mockCallBack}>Next</Button>));
        // button.find('NextButton').simulate('click');
        button.simulate('click');
        expect(mockCallBack.mock.calls.length).toEqual(1);
    });
});




test("update parent", () => {
    const mockCallBack = jest.fn();
    const wrapper = shallow(<NamePage setName={mockCallBack} />);
    wrapper.find(TextField).simulate('blur', { target: { name: "name", value: "value"}} );
    expect(mockCallBack.mock.calls.length).toEqual(1);
    expect(mockCallBack.mock.calls[0][0]).toEqual("value");
});






/*test("update parent11", () => {
    const mockCallBack = jest.fn();
    const wrapper = shallow(<NamePage setName={mockCallBack} />);
    //wrapper.setState({ name: "" });
   // wrapper.instance().updateParent("testName");
    wrapper.find(TextField).simulate('blur', { target: { name: "name", value: "value" } });
    // wrapper.find('TextField').simulate('change', { target: {value:"testName", name: }});
    expect(wrapper.instance().state).toEqual("testName");
});*/
