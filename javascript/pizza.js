//the original code didn't work because the wait pizza has a delay of 3 seconds and the message "Pizza came" appears after "I can eat my pizza"
let pizzas = ["Salami", "Pepperoni", "Veggie", "Margarita"];

function orderPizza(pizzaType) {
  console.log(`1- Ordered pizza with ${pizzaType}`);
}

function waitPizza(pizzaType) {
  return new Promise((resolve) => {
    setTimeout(() => {
      console.log(`2- Pizza with ${pizzaType} came`);
      resolve(pizzaType); // Resolve the promise when the pizza comes
    }, 3000); // Wait for 3 seconds
  });
}

function eatPizza(pizzaType) {
  console.log(`3- I can eat my pizza ${pizzaType}`);
}

// Process each pizza s
async function processAllPizzas() {
  for (let pizza of pizzas) {
    orderPizza(pizza); // Step 1: Order pizza
    await waitPizza(pizza); // Step 2: Wait for pizza to come
    eatPizza(pizza); // Step 3: Eat the pizza
  }
}

processAllPizzas();
