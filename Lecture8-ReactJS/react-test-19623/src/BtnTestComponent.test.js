import React from 'react';
import { render, fireEvent } from '@testing-library/react';
import { BtnTestComponent } from './BtnTestComponent';
import { add } from './add';
import { screen } from '@testing-library/react';
jest.mock('./add', () => ({
  add: jest.fn(),
}));

describe('BtnTestComponent', () => {
  test('should call add function and log the result on button click', () => {
    const randomNum1 = 50;
    const randomNum2 = 75;
    const expectedResult = 125;

    add.mockReturnValue(expectedResult);
    const consoleSpy = jest.spyOn(console, 'log').mockImplementation();

    const { getByTitle } = render(<BtnTestComponent />);
    const button = screen.getByTitle('btn');

    fireEvent.click(button);

    expect(add).toHaveBeenCalledWith(randomNum1, randomNum2);
    expect(consoleSpy).toHaveBeenCalledWith(expectedResult);

    consoleSpy.mockRestore();
  });

  
});

describe('BtnTestComponentf', () => {
  test('should call add function and log the result on button click fail', () => {
    const randomNum1 = 50;
    const randomNum2 = 50;
    const expectedResult = 100;

    add.mockReturnValue(expectedResult);
    const consoleSpy = jest.spyOn(console, 'log').mockImplementation();

    const { getByTitle } = render(<BtnTestComponent />);
    const button = getByTitle('btn');

    fireEvent.click(button);

    expect(add).toHaveBeenCalledWith(randomNum1, randomNum2);
    expect(consoleSpy).toHaveBeenCalledWith(expectedResult);

    consoleSpy.mockRestore();
  });

  
});
