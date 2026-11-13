function sum(a, b) {
  return a + b;
}

function subtract(a, b) {
  return a - b;
}

function multiply(a, b) {
  return a * b;
}

function divide(a, b) {
  if (b === 0) {
    return "Қате: нөлге бөлуге болмайды";
  }

  return a / b;
}

console.log("Қосу:", sum(5, 3));
console.log("Азайту:", subtract(5, 3));
console.log("Көбейту:", multiply(5, 3));
console.log("Бөлу:", divide(6, 3));
console.log("Нөлге бөлу:", divide(5, 0));