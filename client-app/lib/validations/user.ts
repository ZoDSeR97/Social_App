import { z } from "zod";

export const UserValidation = z.object({
    FirstName: z
        .string({ required_error: 'First name is required' })
        .min(2, { message: "Minimum 3 characters." }),
    LastName: z
        .string({ required_error: 'Last name is required' })
        .min(2, { message: "Minimum 3 characters." }),
    Username: z
        .string({ required_error: 'Username is required' })
        .min(2, { message: "Minimum 3 characters." }),
    Email: z
        .string({ required_error: 'Email is required' })
        .email({ message: "Not a valid email." }),
    Password: z
        .string({ required_error: 'Password is required' })
        .min(8, { message: "Minimum 8 characters." }),
    Bio: z
        .string()
        .max(1000, { message: "Maximum 1000 characters." }),
    Avatar: z
        .string()
        .url({ message: "Not a valid url." })
});
