<template>
  <v-card class="mx-auto" max-width="350px">
    <v-card-text>
      <div>Register</div>
      <v-text-field label="Username" model="username"></v-text-field>
      <v-text-field
        v-model="password"
        :append-icon="show1 ? 'mdi-eye' : 'mdi-eye-off'"
        :rules="[rules.required, rules.min]"
        :type="show1 ? 'text' : 'password'"
        name="input-10-1"
        label="Password"
        hint="At least 8 characters"
        counter
        @click:append="show1 = !show1"
      ></v-text-field>
      <v-text-field
            v-model="email"
            :rules="[rules.required, rules.email]"
            label="E-mail"
          ></v-text-field>
    </v-card-text>
    <v-card-actions>
      <v-btn text color="blue" @click="login"> Login </v-btn>
    </v-card-actions>

    <v-dialog v-model="dialog" width="500">
      <v-card>
        <v-card-title class="text-h5"> czesc </v-card-title>

        <v-card-text>
          Poki co to nie dziala. Tzn dziala, ale tylko wyswietla ten komunikat
        </v-card-text>

        <v-divider></v-divider>

        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="primary" text @click="dialog = false">
            Ok, fajnie
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-card>
</template>

<script lang="js">


export default {
  name: "RegisterComponent",

  data: () => ({
    dialog: false,
    email:      '',
    username:   'User',
    password:   '',
    show1: false,
    rules: {
      required: value => !!value || 'Required.',
      min: v => v.length >= 8 || 'Min 8 characters',
      emailMatch: () => (`The email and password you entered don't match`),
    },
  }),

  methods: {
    login() {
        this.dialog = true;
    }
  }
};
</script>

<style scoped lang="scss">

</style>
