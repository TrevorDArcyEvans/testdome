number1 = 8;
function logNumbers() {
  console.log(this.number1);
  console.log(this.number2);
  var number2 = 4;
}

var numberContainer =
{
  number1: 6,
  scopeTest: function (givenFunc) {
    givenFunc();
  }
};

numberContainer.scopeTest(logNumbers);
