import axios from "axios";
import { BACKEND_URL } from '../utils/requests';

const baseURL = `${BACKEND_URL}`;

export default axios.create({
    baseURL,
    headers: {
        // "Authorization": "Bearer xxxxx"
    }
});