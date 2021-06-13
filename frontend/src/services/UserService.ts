import Client from "./Client";
import AuthService from "./AuthService";
import { LoginForm, CadastroForm } from 'types/Auth';

const UserService = {
    
    async register(form: CadastroForm) {
        return (await Client.post<string>("/registrar", form)).data
    },

    async login(form: LoginForm) {
        const id = (await Client.post<number>("/login", form)).data
        AuthService.setToken(id + "");
    },

    isLoggedIn() {
        return !!AuthService.getToken();
    },

    logout() {
        AuthService.clear();
    }
};

export default UserService;

