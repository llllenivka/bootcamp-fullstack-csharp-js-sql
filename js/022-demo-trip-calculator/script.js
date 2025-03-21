const invoiceAmount = document.getElementById("invoiceAmountInput");
const tipPercentage = document.getElementById("tipPercentageInput");
const numberOfPeople = document.getElementById("numberOfPeopleInput");

const calculateBtn = document.getElementById("calculateBtn");

const tipOutput = document.getElementById("tipOutput");
const totalAmountOutput = document.getElementById("totalAmountOutput");
const amountPerPersonOutput = document.getElementById("amountPerPersonOutput");

calculateBtn.addEventListener("click", calculate);

function calculate () {
    if (isNaN(invoiceAmount.Value) || isNaN(tipPercentage.Value) || isNaN(numberOfPeople.Value)) 
    {
       const tip = parseFloat(invoiceAmount.value) / 100 * parseFloat(tipPercentage.value);
        const totalAmount = parseFloat(invoiceAmount.value) + tip;
        const amountPerPerson = totalAmount / parseFloat(numberOfPeople.value);

        tipOutput.textContent = "Чаевые: " + tip.toFixed(2);
        totalAmountOutput.textContent = "Общая сумма: " + totalAmount.toFixed(2);
        amountPerPersonOutput.textContent = "Сумма на человека: " + amountPerPerson.toFixed(2);``
    }
    else
    {
        alert("Пожалуйста, введите корректные числовые значения.");
        
    }
}