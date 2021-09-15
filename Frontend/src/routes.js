import Index from "./views/home/Index.js";
import Login from "./views/auth/Login.js";
import Cakes from "./views/cakes/Index.js";
import CakeCreate from "./views/cakes/Create.js";
import CakeEdit from "./views/cakes/Edit.js";
import Categories from "./views/categories/Index.js";
import CategoryCreate from "./views/categories/Create.js";
import CategoryEdit from "./views/categories/Edit.js";
import Users from "./views/users/Users.js";

var routes = [
  {
    path: "/index",
    name: "Dashboard",
    icon: "fas fa-chart-line text-primary",
    component: Index,
    layout: "/admin",
    isSideBar: true,
  },

  {
    path: "/categories/create",
    name: "Add new category",
    icon: "",
    component: CategoryCreate,
    layout: "/admin",
    isSideBar: false,
  },
  {
    path: "/categories/:id/edit",
    name: "Edit category",
    icon: "",
    component: CategoryEdit,
    layout: "/admin",
    isSideBar: false,
  },
  {
    path: "/categories",
    name: "Categories",
    icon: "fas fa-list-ul text-danger",
    component: Categories,
    layout: "/admin",
    isSideBar: true,
  },
  {
    path: "/cakes/create",
    name: "Add new cake",
    icon: "",
    component: CakeCreate,
    layout: "/admin",
    isSideBar: false,
  },
  {
    path: "/cakes/:id/edit",
    name: "Edit cake",
    icon: "",
    component: CakeEdit,
    layout: "/admin",
    isSideBar: false,
  },
  {
    path: "/cakes",
    name: "Cakes",
    icon: "fas fa-birthday-cake text-warning",
    component: Cakes,
    layout: "/admin",
    isSideBar: true,
  },
  {
    path: "/users",
    name: "Users",
    icon: "fas fa-users text-success",
    component: Users,
    layout: "/admin",
    isSideBar: true,
  },
  {
    path: "/login",
    name: "Login",
    icon: "fas fa-sign-in-alt text-info",
    component: Login,
    layout: "/auth",
    isSideBar: false,
  },
];
export default routes;
