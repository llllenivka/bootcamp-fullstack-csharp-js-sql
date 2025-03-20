let countPeople = Number(prompt('Сколько людей?'));
let cost = Number(prompt('Общий счет:'));
let tip = Number(prompt('Какой процент чаевых'));

alert((cost + (cost / 100 * tip)) / countPeople);