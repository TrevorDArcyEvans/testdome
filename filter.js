var arr = [1, 'a', 'b', 2, 62.1, { 'a': 21 }];
var filtered = arr.filter(function (item) {
  return (parseInt(item) === item);
});

console.log(filtered);
