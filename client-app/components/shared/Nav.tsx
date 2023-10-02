import Link from "next/link";
import Image from "next/image";
import { SignedIn, SignOutButton, OrganizationSwitcher } from "@clerk/nextjs";
import { dark } from "@clerk/themes";

export const Nav = () => {
    return (
        <nav className="topbar">
            <div>
                <Link href="/" className="flex items-center gap-4">
                    <Image src="/next.svg" alt="logo" width={28} height={28} />
                    <h1 className="text-heading3-bold text-light-1 max-xs:hidden">Social App</h1>
                </Link>
                <div className="flex items-center gap-1">
                    <div className="block md:hidden">
                        <SignedIn>
                            <SignOutButton>
                                <Image src="/next.svg" alt="logout" width={20} height={20} />
                            </SignOutButton>
                        </SignedIn>
                    </div>
                </div>
                <OrganizationSwitcher
                    appearance={
                        {
                            baseTheme: dark,
                            elements: {
                                organizationSwitcherTrigger: "py-2 px-4"
                            }
                        }
                    }
                />
            </div>
        </nav>
    )
}