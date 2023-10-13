import { z } from "zod";

export const UserValidation = z.object({
    profile_photo: z.string().url().nonempty(),
    first_name: z
        .string()
        .min(2, { message: "Minimum 3 characters." }),
    last_name: z
        .string()
        .min(2, { message: "Minimum 3 characters." }),
    username: z
        .string()
        .min(3, { message: "Minimum 3 characters." }),
    bio: z
        .string()
        .min(3, { message: "Minimum 3 characters." })
        .max(1000, { message: "Maximum 1000 caracters." }),
})
