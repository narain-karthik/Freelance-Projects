const dateFromInput = document.getElementById('date_from');
const dateToInput = document.getElementById('date_to');
const totalDaysInput = document.getElementById('total_days');
const totalBudgetInput = document.getElementById('total_budget');
const dailyBudgetInput = document.getElementById('daily_budget');
const form = document.querySelector('form');

function calculateDaysAndBudget() {
    const dateFrom = new Date(dateFromInput.value);
    const dateTo = new Date(dateToInput.value);
    const totalBudget = parseFloat(totalBudgetInput.value) || 0;

    if (dateFrom && dateTo) {
        if (dateFrom > dateTo) {
            alert('To Date must be after From Date.');
            dateToInput.value = '';
            totalDaysInput.value = '';
            dailyBudgetInput.value = '';
            return;
        }
        const timeDiff = dateTo - dateFrom;
        const totalDays = Math.ceil(timeDiff / (1000 * 60 * 60 * 24)) + 1;
        totalDaysInput.value = totalDays;

        if (totalBudget > 0 && totalDays > 0) {
            const dailyBudget = totalBudget / totalDays;
            dailyBudgetInput.value = dailyBudget.toFixed(2);
        } else {
            dailyBudgetInput.value = '';
        }
    } else {
        totalDaysInput.value = '';
        dailyBudgetInput.value = '';
    }
}

dateFromInput.addEventListener('change', calculateDaysAndBudget);
dateToInput.addEventListener('change', calculateDaysAndBudget);
totalBudgetInput.addEventListener('input', calculateDaysAndBudget);

form.addEventListener('submit', (e) => {
    if (!totalDaysInput.value || !dailyBudgetInput.value) {
        e.preventDefault();
        alert('Please ensure all dates and budget are correctly filled.');
    }
});