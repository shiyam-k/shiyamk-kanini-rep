<template>
    <div>
      <table class="table table-striped table-hover table-secondary">
        <thead class="table-dark">
          <tr class="tb">
            <th>Name</th>
            <th>Email</th>
            <th>Age</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(person, index) in people" :key="index" class="tb">
            <td>{{ person.name }}</td>
            <td>{{ person.email }}</td>
            <td>{{ person.age }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        people: [
          { name: "Sandie", email: "san@example.com", age: 90 },
          { name: "Jeevs", email: "jeev@example.com", age: 75 },
          { name: "Boovie", email: "boo@example.com", age: 2000 },
          { name: "mallvin", email: "malls@example.com", age: 300 },
          { name: "panindia", email: "pan@example.com", age: 9000 },

        ],
      };
    },
  };
  </script>
  
  <style scoped>
  tr:hover{
    cursor: pointer;
    background-color: hsla(0, 0%, 98%, 0.2)
  }
  
  </style>
  