/*
   ColorProject

   Author: Paige Kusper
   Date:   08/21/17

   Filename:         ColorProject.htm
   Supporting files: ColorProject.css, ColorProject.js
*/

// First button. 

function randomize() {
  document.getElementById('color1').style.color = randomColors();
}

function randomColors() {
  return '#' + Math.floor(Math.random() * 16777215).toString(16);
}

// Second button.

function randomize2() {
  document.getElementById('color2').style.color = randomColors2();
}

function randomColors2() {
  return '#' + Math.floor(Math.random() * 16777215).toString(16);
}

// Header with color name.

function randomizeHeader() {
  document.getElementById('header').style.color = randomColors3();
}

function randomColors3() {
  return '#' + Math.floor(Math.random() * 16777215).toString(16);
}