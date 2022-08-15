<template>
  <div class="gunsManagement">
    <div class="gunsManagement-form">
      <div class="mt-5">
        <div class="gunsManagement-header">
          <h2>All Guns</h2>
          <div>
            <v-btn @click.prevent="addGunDialog = true" color="accent">
              <v-icon class="margin-right-small">mdi-plus-circle</v-icon>
              Add Gun
            </v-btn>
          </div>
        </div>
        <div class="d-flex">
          <v-row>
            <v-col>
            </v-col>
            <v-spacer></v-spacer>
            <v-col class="d-flex">
              <v-icon>mdi-magnify</v-icon>
              <v-text-field
                v-model="searchField"
                label="Start typing"
                clearable
              >
              </v-text-field>
            </v-col>
          </v-row>
        </div>
        <v-simple-table>
          <template v-slot:default>
            <thead>
              <tr>
                <th class="text-left">Gun name</th>
                <th class="text-left">Category</th>
                <th class="text-left">Version</th>
                <th class="text-left">Type</th>
                <th class="text-left">Brand</th>
                <th class="text-left">Caliber</th>
                <th class="text-left"></th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="gun in gunsList" :key="gun.id">
                <td>{{ gun.model }}</td>
                <td>{{ gun.category }}</td>
                <td>{{ gun.version }}</td>
                <td>{{ gun.type }}</td>
                <td>{{ gun.brand }}</td>
                <td>{{ gun.caliber }}</td>
                <td align="right">
                  <div class="my-auto">
                    <v-btn icon @click.prevent="editGun(gun)">
                      <v-icon>mdi-pencil</v-icon>
                    </v-btn>
                    <v-btn icon @click.prevent="removeGun(gun)">
                      <v-icon>mdi-delete</v-icon>
                    </v-btn>
                  </div>
                </td>
              </tr>
            </tbody>
          </template>
        </v-simple-table>
      </div>
    </div>
    <v-dialog v-model="addGunDialog" max-width="800" persistent>
      <AddGunForm
        v-if="addGunDialog"
        @closeDialog="addGunDialog = false"
      />
    </v-dialog>
    <v-dialog v-model="editGunDialog" max-width="800" persistent>
      <EditGunForm
        v-if="editGunDialog"
        :gun="editedGun"
        @closeDialog="editGunDialog = false"
      />
    </v-dialog>
  </div>
</template>

<script lang="js">

import AddGunForm from "./forms/AddGunForm";
import EditGunForm from "./forms/EditGunForm";
import { mapState } from "vuex";
import { REMOVE_GUN } from "@/store/actions";

export default {
  name: "GunsManagementPane",
  components: {
    AddGunForm,
    EditGunForm,
  },
  data() {
    return {
      addGunDialog: false,
      editGunDialog: false,
      editedGun: undefined,
      searchField: ''
    };
  },
  computed: {
    ...mapState({
      state: (state) => {
        return state;
      },
    }),
    gunsList() {
      return this.state.guns.all.filter(x=> x.model.toLowerCase().startsWith(this.searchField.toLowerCase()));
    }
  },
  methods: {
    async removeGun(alias) {
      this.$store.dispatch(REMOVE_GUN, alias);
    },
    editGun(gun) {
      this.editedGun = gun;
      this.editGunDialog = true;
    }
  },
};
</script>

<style scoped lang="scss">

.gunsManagement {
  padding-top: 20px;
  width: 100%;
}

.gunsManagement-form {
  margin-left: 10px;
  padding-top: 30px;
  width: 95%;
}

.gunsManagement-form > {
  padding-top: 20px;
}

.gunsManagement-header {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  padding-bottom: 10px;
}
</style>