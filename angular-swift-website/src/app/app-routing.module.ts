import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './_home/home/home.component';
import { AuthGuard } from './_helpers/auth.guard';

import { LoginComponent } from './_accounts/login/login.component';
import { RegisterComponent } from './_accounts/register/register.component';
import { CartComponent } from './cart/cart.component';
import { ProductListComponent } from './product-list/product-list.component';

const accountModule = () => import('./_accounts/account.module').then(x => x.AccountModule);
const usersModule = () => import('./_user/users.module').then(x => x.UsersModule);

const routes: Routes = [
  // {path: '', redirectTo: ''},
  {path: 'login', component: LoginComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'Home', component: ProductListComponent},
  {path: '', component: ProductListComponent},

    // { path: '', component: HomeComponent, canActivate: [AuthGuard] },
  //{ path: 'users', loadChildren: usersModule, canActivate: [AuthGuard] },
    // { path: 'account', loadChildren: accountModule },

    // otherwise redirect to home
    // { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
